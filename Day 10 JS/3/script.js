const inputField = document.querySelector('.txt-feild');
const startBtn = document.getElementById('start-countdown');
const countDisplay = document.querySelector('.count');
const historyBox = document.querySelector('.history');

let timerInterval = null;
const originalBackground = "linear-gradient(to bottom, #09334f, #115d8f)";
const successBackground = "linear-gradient(to bottom, #0d382c, #1b5e4b)";

startBtn.addEventListener('click', () => {
    const value = parseInt(inputField.value.trim());

    if (isNaN(value) || value <= 0) {
        countDisplay.style.color = "#ff5555";
        countDisplay.style.fontSize = "1.2rem";
        countDisplay.textContent = "Please enter a valid positive number!";
        return;
    }

    clearInterval(timerInterval);
    document.body.style.background = originalBackground;
    
    let currentCount = value;
    countDisplay.style.color = "white";
    countDisplay.style.fontSize = "2.5rem";
    countDisplay.textContent = currentCount;

    startBtn.disabled = true;
    inputField.disabled = true;

    timerInterval = setInterval(() => {
        currentCount--;

        if (currentCount > 0) {
            countDisplay.textContent = currentCount;
        } else {
            clearInterval(timerInterval);
            
            countDisplay.style.color = "#2ecc71";
            countDisplay.style.fontSize = "2.5rem";
            countDisplay.textContent = "TIME UP";
            
            document.body.style.background = successBackground;

            const historyItem = document.createElement('div');
            historyItem.textContent = `• Completed: ${value} seconds`;
            historyBox.prepend(historyItem);

            startBtn.disabled = false;
            inputField.disabled = false;
            inputField.value = "";
        }
    }, 1000);
});