const himna = new Audio();

function playAudio(audio) {
    himna.src = `./audio/${audio}`;

    console.log("audio");
    console.log(audio);
    himna.play();
}

function stopAudio() {
    console.log("stop");
    himna.pause();
}
