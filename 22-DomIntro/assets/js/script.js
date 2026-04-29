
const container = document.getElementById('card-container');

const card = document.createElement('div');
const title = document.createElement('h2');
const description = document.createElement('p');
const button = document.createElement('button');


title.textContent = "Məhsul Kartı";
description.textContent = "Bu kartın bütün dizaynı və stilləri birbaşa JavaScript tərəfindən idarə olunur.";
button.textContent = "Daha çox";

const bodyStyle = document.body.style;
bodyStyle.backgroundColor = "#f0f2f5";
bodyStyle.display = "flex";
bodyStyle.justifyContent = "center";
bodyStyle.alignItems = "center";
bodyStyle.height = "100vh";
bodyStyle.margin = "0";
bodyStyle.fontFamily = "Arial, sans-serif";

card.style.width = "300px";
card.style.backgroundColor = "white";
card.style.padding = "20px";
card.style.borderRadius = "15px";
card.style.boxShadow = "0 4px 8px rgba(0,0,0,0.1)";
card.style.textAlign = "center";
card.style.transition = "transform 0.3s ease";

title.style.color = "#333";
title.style.marginBottom = "15px";

description.style.color = "#666";
description.style.fontSize = "14px";
description.style.lineHeight = "1.5";
description.style.marginBottom = "20px";

button.style.backgroundColor = "#007bff";
button.style.color = "white";
button.style.border = "none";
button.style.padding = "10px 20px";
button.style.borderRadius = "5px";
button.style.cursor = "pointer";
button.style.fontSize = "16px";
button.style.transition = "background-color 0.3s";

card.onmouseover = () => {
    card.style.transform = "scale(1.05)";
};
card.onmouseout = () => {
    card.style.transform = "scale(1)";
};

button.onclick = function() {
    alert("Düyməyə klikləndi!");
    this.style.backgroundColor = "#28a745"; // Rəngi yaşıl et
    this.textContent = "Seçildi";
};

card.appendChild(title);
card.appendChild(description);
card.appendChild(button);
container.appendChild(card);