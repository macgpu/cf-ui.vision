//Global
fetch('/api/version').then(function(r){return r.json();}).then(function(d){
    var el=document.getElementById('site-version');
    if(el)el.textContent=d.version;
}).catch(function(){});


//Submit the contact us form
function submitContactForm() {
    $("#ocrContactForm").submit();
}

//Smooth Scrolling
$(function () {
    $('a[href*=#]:not([href=#])').click(function () {
        if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') && location.hostname == this.hostname) {
            var target = $(this.hash);
            target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
            if (target.length) {
                $('html,body').animate({
                    scrollTop: target.offset().top
                }, 1000);
                //return false;
            }
        }
    });
});

