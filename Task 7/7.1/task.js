var inputString = 'У попа была собака';
const separator = [' ', '    ', '?', '!', '\"', ':', ';', ',', '.']

function charRemover(string) {
    var wordsArray = string.split(' ');
    var removeChar = [];
    var newString = string;

    wordsArray.forEach(word => {
        for (var index = 0; index < word.length; index++) {
            if (word.indexOf(word[index]) != word.indexOf(word[index], word.indexOf(word[index]) + 1) && word.indexOf(word[index], word.indexOf(word[index]) + 1) != -1) {
                removeChar.push(word[index]);
            }
        }

    });

    removeChar.forEach(element => {
       for (let index = 0; index < newString.length; index++) {
        newString = newString.replace(element, ''); 
       }

    });

    return newString;
}

console.log(charRemover(inputString));