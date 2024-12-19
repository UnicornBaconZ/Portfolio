document.addEventListener('DOMContentLoaded', function () {
    var allAudioCards = document.querySelectorAll('.media-card');
    var currentPlayingAudio = null;
    var currentPlayingButton = null;

    allAudioCards.forEach(function (card) {
        var audio = card.querySelector('audio');
        var controlButton = card.querySelector('.audio-control');
        var icon = controlButton.querySelector('i'); 
        var progressBar = card.querySelector('.progress-bar');

        audio.addEventListener('canplay', function () {
            audio.volume = 0.2;
        });

        controlButton.onclick = function () {
            var isPaused = audio.paused;

            if (currentPlayingAudio && currentPlayingAudio !== audio) {
                currentPlayingAudio.pause();
                currentPlayingAudio.currentTime = 0;

                if (currentPlayingButton) {
                    var previousIcon = currentPlayingButton.querySelector('i');
                    previousIcon.classList.remove('fa-pause');
                    previousIcon.classList.add('fa-play');
                }
            }

            if (isPaused) {
                audio.play();
                icon.classList.remove('fa-play');
                icon.classList.add('fa-pause');
                currentPlayingAudio = audio;
                currentPlayingButton = controlButton;
            } else {
                audio.pause();
                icon.classList.remove('fa-pause');
                icon.classList.add('fa-play');
                currentPlayingAudio = null;
                currentPlayingButton = null;
            }

            return false;
        };

        audio.addEventListener('timeupdate', function () {
            var progress = (audio.currentTime / audio.duration) * 100 || 0;
            progressBar.value = progress - 1; // Adjusted to fix whitespace issue
            progressBar.style.setProperty('--progress', `${progress}%`);
        });

        progressBar.addEventListener('input', function () {
            var seekTime = (progressBar.value / 100) * audio.duration;
            audio.currentTime = seekTime;
        });
    });
});
