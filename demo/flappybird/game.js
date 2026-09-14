/*
 * Flappy Bird clone - adapted for the Ui.Vision demo page /demo/flappybird
 * Original game: https://github.com/nolanjp/flappybird-web (by Nolan)
 * Sprites and sounds: https://github.com/samuelcust/flappy-bird-assets
 *
 * Changes for the demo page: absolute asset paths, game runs inside the #game
 * container instead of the full window, live score and game state are mirrored
 * into the DOM (#score, #game[data-state]) so automation tools can read them,
 * spacebar no longer scrolls the page while playing.
 */
(function () {
    var ASSETS = '/demo/flappybird/assets/';

    var board, ctx;
    var boardWidth = 360, boardHeight = 640;
    var birdWidth = 34, birdHeight = 24;
    var birdX = boardWidth / 8, birdY = boardHeight / 2;
    var birdImg, bird = { x: birdX, y: birdY, width: birdWidth, height: birdHeight };

    var pipes = [], pipeWidth = 64, pipeHeight = 512, pipeX = boardWidth;
    var topPipeImg, bottomPipeImg;

    var gravity = 0.4, velocityY = 0, velocityX = -2;
    var isGameStarted = false, gameOver = false, loaded = false, score = 0, best = 0;

    var flapSound = new Audio(ASSETS + 'sound/flap.mp3');
    var passPipeSound = new Audio(ASSETS + 'sound/pass_pipe.mp3');
    var deathSound = new Audio(ASSETS + 'sound/gameover.mp3');
    var swooshSound = new Audio(ASSETS + 'sound/swoosh.mp3');

    var pipeInterval;
    var gameEl, messageImg, scoreEl, bestEl, soundEl, visualOnlyEl;
    var state = 'menu';

    function play(sound) {
        if (soundEl && !soundEl.checked) return;
        try {
            sound.currentTime = 0;
            var p = sound.play();
            if (p && p.catch) p.catch(function () { /* autoplay blocked - ignore */ });
        } catch (e) { /* ignore */ }
    }

    function visualOnly() {
        return !!(visualOnlyEl && visualOnlyEl.checked);
    }

    // Mirror game state into the DOM (#game[data-state], #score, #best-score) - unless
    // "visual game play only" is checked, then the DOM tells nothing and bots must use vision.
    function syncDom() {
        var off = visualOnly();
        var infos = document.querySelectorAll('#game-status .dom-info');
        for (var i = 0; i < infos.length; i++) infos[i].classList.toggle('off', off);
        if (off) {
            gameEl.removeAttribute('data-state');
            scoreEl.textContent = '–';
            bestEl.textContent = '–';
        } else {
            gameEl.setAttribute('data-state', state);
            scoreEl.textContent = Math.floor(score);
            bestEl.textContent = best;
        }
    }

    function setState(value) {
        state = value;
        syncDom();
    }

    function setScore(value) {
        score = value;
        if (!visualOnly()) scoreEl.textContent = Math.floor(score);
    }

    // In "visual game play only" mode, synthetic events (dispatched by scripts, e.g. a DOM
    // click from an automation tool) are ignored - only real mouse/keyboard input counts.
    function trusted(e) {
        return !visualOnly() || !e || e.isTrusted !== false;
    }

    function init() {
        gameEl = document.getElementById('game');
        board = document.getElementById('board');
        board.width = boardWidth;
        board.height = boardHeight;
        ctx = board.getContext('2d');

        birdImg = new Image();
        birdImg.src = ASSETS + 'images/flappybird.png';

        topPipeImg = new Image();
        topPipeImg.src = ASSETS + 'images/toppipe.png';

        bottomPipeImg = new Image();
        bottomPipeImg.src = ASSETS + 'images/bottompipe.png';

        messageImg = document.getElementById('message-image');
        scoreEl = document.getElementById('score');
        bestEl = document.getElementById('best-score');
        soundEl = document.getElementById('sound');
        visualOnlyEl = document.getElementById('visual-only');
        if (visualOnlyEl) visualOnlyEl.addEventListener('change', syncDom);

        document.getElementById('start-button').addEventListener('click', function (e) { if (trusted(e)) loadGame(); });
        document.getElementById('restart-button').addEventListener('click', function (e) { if (trusted(e)) restartGame(); });

        // Mouse click on the canvas = flap
        board.addEventListener('click', function (e) { if (trusted(e)) jump(); });
        // Spacebar = flap (only once the game has been loaded, so the page scrolls normally before that)
        document.addEventListener('keydown', function (e) {
            var isSpace = e.code === 'Space' || e.key === ' ' || e.key === 'Spacebar' || e.keyCode === 32;
            if (!isSpace || !loaded || !trusted(e)) return;
            var t = e.target;
            if (t && (t.tagName === 'INPUT' || t.tagName === 'TEXTAREA' || t.tagName === 'SELECT' || t.tagName === 'BUTTON')) return;
            e.preventDefault();
            jump();
        });

        setState('menu');
        setScore(0);
    }

    function loadGame() {
        play(swooshSound);
        document.getElementById('main-menu').style.display = 'none';
        loaded = true;
        isGameStarted = false;
        velocityY = 0;
        setScore(0);
        bird.y = birdY;

        messageImg.style.display = 'block';
        setState('ready');

        ctx.clearRect(0, 0, board.width, board.height);
        ctx.drawImage(birdImg, bird.x, bird.y, bird.width, bird.height);
        requestAnimationFrame(update);
    }

    function startGame() {
        if (!isGameStarted) {
            isGameStarted = true;
            velocityY = -6;
            play(flapSound);
            pipeInterval = setInterval(addPipes, 1500);

            messageImg.style.display = 'none';
            setState('playing');
        }
    }

    function update() {
        if (gameOver) return;
        ctx.clearRect(0, 0, board.width, board.height);

        if (isGameStarted) {
            velocityY += gravity;
            bird.y = Math.max(bird.y + velocityY, 0);
        }
        ctx.drawImage(birdImg, bird.x, bird.y, bird.width, bird.height);

        if (bird.y > board.height) endGame();

        pipes.forEach(function (pipe) {
            pipe.x += velocityX;
            ctx.drawImage(pipe.img, pipe.x, pipe.y, pipe.width, pipe.height);

            if (!pipe.passed && bird.x > pipe.x + pipe.width) {
                setScore(score + 0.5); // two pipes per gap -> +1 per gap
                pipe.passed = true;
                play(passPipeSound);
            }

            if (isCollision(bird, pipe)) endGame();
        });

        pipes = pipes.filter(function (pipe) { return pipe.x >= -pipeWidth; });

        ctx.fillStyle = 'white';
        ctx.font = '45px sans-serif';
        ctx.fillText(Math.floor(score), 5, 45);

        requestAnimationFrame(update);
    }

    function addPipes() {
        if (gameOver || !isGameStarted) return;
        var gap = boardHeight / 4;
        var randomY = -pipeHeight / 4 - Math.random() * (pipeHeight / 2);

        pipes.push({ img: topPipeImg, x: pipeX, y: randomY, width: pipeWidth, height: pipeHeight, passed: false });
        pipes.push({ img: bottomPipeImg, x: pipeX, y: randomY + pipeHeight + gap, width: pipeWidth, height: pipeHeight, passed: false });
    }

    function jump() {
        if (!loaded) return;
        if (!isGameStarted) {
            startGame();
        } else if (!gameOver) {
            velocityY = -6;
            play(flapSound);
        } else {
            restartGame();
        }
    }

    function isCollision(b, pipe) {
        return b.x < pipe.x + pipe.width &&
               b.x + b.width > pipe.x &&
               b.y < pipe.y + pipe.height &&
               b.y + b.height > pipe.y;
    }

    function endGame() {
        if (gameOver) return;
        gameOver = true;
        clearInterval(pipeInterval);
        play(deathSound);
        var finalScore = Math.floor(score);
        if (finalScore > best) {
            best = finalScore;
            if (!visualOnly()) bestEl.textContent = best;
        }
        document.getElementById('final-score').textContent = finalScore;
        document.getElementById('gameover-menu').style.display = 'flex';
        setState('gameover');
    }

    function restartGame() {
        gameOver = false;
        pipes = [];
        velocityY = 0;
        setScore(0);
        bird.y = birdY;
        document.getElementById('gameover-menu').style.display = 'none';
        loadGame();
    }

    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', init);
    } else {
        init();
    }
})();
