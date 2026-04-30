let currentInput = '0';
let operator = null;
let previousInput = null;

const screen = document.getElementById('screen');

function updateScreen() {
    screen.value = currentInput;
}

function appendNumber(number) {
    if (currentInput === '0' && number !== '.') {
        currentInput = number;
    } else {
        // Nöqtənin təkrarlanmasının qarşısını almaq
        if (number === '.' && currentInput.includes('.')) return;
        currentInput += number;
    }
    updateScreen();
}

function appendOperator(op) {
    if (operator !== null) {
        calculate(); // Ardıcıl əməliyyat üçün (məs: 5+5+)
    }
    previousInput = currentInput;
    operator = op;
    currentInput = '0';
}

function clearScreen() {
    currentInput = '0';
    operator = null;
    previousInput = null;
    updateScreen();
}

function calculate() {
    if (operator === null || previousInput === null) return;

    let result;
    const prev = parseFloat(previousInput);
    const current = parseFloat(currentInput);

    switch (operator) {
        case '+':
            result = prev + current;
            break;
        case '-':
            result = prev - current;
            break;
        case '*':
            result = prev * current;
            break;
        case '/':
            if (current === 0) {
                alert("Sıfıra bölmək olmaz!");
                clearScreen();
                return;
            }
            result = prev / current;
            break;
        default:
            return;
    }

    currentInput = result.toString();
    operator = null;
    previousInput = null;
    updateScreen();
}