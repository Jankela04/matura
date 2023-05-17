const iframe = document.getElementById("iframe");
const bigPicture = document.getElementById("main-pic");

function setImg(x) {
    iframe.src = `./sajt/sajt${x}.html`;
    bigPicture.src = `./img/slika${x}.jpg`;
}
