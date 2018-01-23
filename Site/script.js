function moveSpaceship() {
    var elem = document.querySelector(".spaceship"),
        speed = 1,
        currentPos = 0;
    var currentUp = -600;


    elem.style.left = -50 + "px";
    elem.style.bottom = -600 + "px";

    var motionInterval = setInterval(function () {
        currentPos += speed;
        currentUp += speed * 5;
        console.log(currentPos);

        if (currentPos >= 200 && speed > 0) {
            currentPos = 0;
            currentUp = -600;
            speed = 1 * speed;
        }
        if (currentPos <= 0 && speed < 0) {
            clearInterval(motionInterval);
        }
        elem.style.left = currentPos * 10 + "px";
        elem.style.bottom = currentUp + "px";
    }, 20);


}

moveSpaceship();

var playBtn = document.querySelector('.download');
var logoHead = document.querySelector('.logo');
var video = document.querySelector('.video-container');
var box = document.querySelector('.box');

function showMovie() {
    video.classList.remove('hidden');
    logoHead.classList.add('hidden');
    box.classList.add('hidden');
}

playBtn.addEventListener("mousedown", showMovie);
