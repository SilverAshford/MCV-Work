const fortunes = [
  "You will have a great day!",
  "A surprise is waiting for you.",
  "Hard work will pay off today.",
  "A new opportunity is coming your way.",
  "Trust your instincts."
];

const button = document.querySelector("button");
const fortuneText = document.getElementById("fortune");

button.addEventListener("click", () => {
  const randomIndex = Math.floor(Math.random() * fortunes.length);
  
  fortuneText.textContent = fortunes[randomIndex];
});