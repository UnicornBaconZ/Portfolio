document.addEventListener('DOMContentLoaded', function () {
    var allAudioCards = document.querySelectorAll('.media-card');
    var currentPlayingAudio = null; 

    allAudioCards.forEach(function (card) {
        var audio = card.querySelector('audio');
        var controlButton = card.querySelector('button');
        var icon = controlButton.querySelector('i');

        controlButton.onclick = function () {
            var isPaused = audio.paused;

            if (currentPlayingAudio && currentPlayingAudio !== audio) {
                currentPlayingAudio.pause(); 
                currentPlayingAudio.currentTime = 0;
                currentPlayingAudio.closest('.media-card').querySelector('i').classList.remove('fa-pause');
                currentPlayingAudio.closest('.media-card').querySelector('i').classList.add('fa-play');
            }

            if (isPaused) {
                audio.play();
                icon.classList.remove('fa-play');
                icon.classList.add('fa-pause');
                currentPlayingAudio = audio; 
            } else {
                audio.pause();
                icon.classList.remove('fa-pause');
                icon.classList.add('fa-play');
                currentPlayingAudio = null; 
            }

            return false; 
        };
    });
});
