const rocket = document.querySelector("p");
const button = document.querySelector("button");
const body = document.querySelector("body");
const state = document.querySelector(".state");

button.addEventListener("click", () => {
    rocket.style.transform = "translate(600px, -500px)";
    button.style.backgroundColor = "#601ea5";
    button.style.color = "#bdbdbd";
    body.style.backgroundColor = "#1d0536";
    
    state.style.opacity = "0";

    setTimeout(() => {
        state.textContent = "🌔";
        state.style.opacity = "1";
    }, 500);
});