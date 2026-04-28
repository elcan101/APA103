function removeDuplicates(arr) {
    let uniqueArray = [...new Set(arr)];
    let count = arr.length - uniqueArray.length;
    
    return {
        result: uniqueArray,
        removedCount: count
    };
}


const nums = [1, 2, 2, 3, 4, 4, 5];
console.log(removeDuplicates(nums)); 


function isPalindrome(word) {
    let reversed = word.split('').reverse().join('');
    return word.toLowerCase() === reversed.toLowerCase();
}

console.log(isPalindrome("radar")); 
console.log(isPalindrome("salam")); 

function countGreaterElements(arr, num) {
    let count = 0;
    for (let i = 0; i < arr.length; i++) {
        if (num < arr[i]) {
            count++;
        }
    }
    return count;
}

const data = [10, 20, 30, 40, 50];
console.log(countGreaterElements(data, 25)); 


function checkAbundance(n) {
    let sum = 0;
    for (let i = 1; i < n; i++) {
        if (n % i === 0) {
            sum += i;
        }
    }

    if (sum > n) {
        return `${n} Abundant ədəddir.`;
    } else {
        return `${n} Deficient ədəddir.`;
    }
}


console.log(checkAbundance(12)); 
console.log(checkAbundance(13)); /


function squareArray(arr) {
    return arr.map(x => x * x);
}

const original = [2, 3, 4, 5];
const squared = squareArray(original);
console.log(squared); 