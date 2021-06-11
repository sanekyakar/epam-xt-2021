var expression = '3.5 +4*10-5.3 /5 =';
expression = removeSpace(expression);
var reg = /(\b[0-9]\.{1}[0-9]+)|(\b[0-9]+)/g;
var splitedExpression = expression.split(reg);
var newSplitedExpression = [];
var j = 0;
splitedExpression.forEach(element => {
    if (!(element === undefined || element == '')) {
        newSplitedExpression.push(element);
    }
});

function MathCalculator(expression) {
    while (newSplitedExpression.length != 1) {
        for (var index = 0; newSplitedExpression.length != 1; index++) {
            if (newSplitedExpression[index] === '*') {
                splitedExpression = [];
                newSplitedExpression[index] = parseFloat(newSplitedExpression[index - 1]) * parseFloat(newSplitedExpression[index + 1])
                newSplitedExpression[index - 1] = null;
                newSplitedExpression[index + 1] = null;

                newSplitedExpression.forEach(element => {
                    if (element != null) {
                        splitedExpression[j] = element;
                        j++;
                    }
                });

                newSplitedExpression = splitedExpression;
                j = 0;
                index = 0;
                break;
            }
            else if (newSplitedExpression[index] === '/' && newSplitedExpression[index] != '-') {
                splitedExpression = [];
                
                newSplitedExpression[index] = parseFloat(newSplitedExpression[index - 1]) / parseFloat(newSplitedExpression[index + 1])
                newSplitedExpression[index - 1] = null;
                newSplitedExpression[index + 1] = null;

                newSplitedExpression.forEach(element => {
                    if (element != null) {
                        splitedExpression[j] = element;
                        j++;
                    }
                });

                newSplitedExpression = splitedExpression;
                j = 0;
                index = 0;
                break;

            }
            else if (!newSplitedExpression.includes('*') && !newSplitedExpression.includes('/') && newSplitedExpression[index] === '-') {
                splitedExpression = [];
                newSplitedExpression[index] = parseFloat(newSplitedExpression[index - 1]) - parseFloat(newSplitedExpression[index + 1])
                newSplitedExpression[index - 1] = null;
                newSplitedExpression[index + 1] = null;

                newSplitedExpression.forEach(element => {
                    if (element != null) {
                        splitedExpression[j] = element;
                        j++;
                    }
                });

                newSplitedExpression = splitedExpression;
                j = 0;
                index = 0;
                break;
            }
            else if (!newSplitedExpression.includes('*') && !newSplitedExpression.includes('/') && newSplitedExpression[index] === '+') {
                splitedExpression = [];
                newSplitedExpression[index] = parseFloat(newSplitedExpression[index - 1]) + parseFloat(newSplitedExpression[index + 1])
                newSplitedExpression[index - 1] = null;
                newSplitedExpression[index + 1] = null;

                newSplitedExpression.forEach(element => {
                    if (element != null) {
                        splitedExpression[j] = element;
                        j++;
                    }
                });

                newSplitedExpression = splitedExpression;
                j = 0;
                index = 0;
                break;
            }


        };
    }

    return newSplitedExpression;
}

function removeSpace(string) {
    var newString = string;
    newString = newString.replace('=', '');
    for (let index = 0; index < newString.length; index++) {
        newString = newString.replace(' ', '');
    }
    return newString;
}

console.log(MathCalculator(expression));
