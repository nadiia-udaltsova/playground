var phrase = "the cat in the hat";
var index = phrase.indexOf("cat");
console.log("there's a cat sitting at index " + index);
index = phrase.indexOf("the", 5);
console.log("there's a the sitting at index " + index);
index = phrase.indexOf("dog");
console.log("there's a dog sitting at index " + index);

var data = "name|phone|address";
var val = data.substring(5,10);
console.log("Substring is " + val);
val = data.substring(5);
console.log("Substring is " + val);

var data1 = "name|phone|address";
var vals = data.split("|");
console.log("Split array is " , vals);

function printTime() {
    var d = new Date();
    var hours = d.getHours();
    var mins = d.getMinutes();
    var secs = d.getSeconds();
    document.body.innerHTML = hours+':'+mins+':'+secs;
}
setInterval(printTime,1000);

var n = prompt ('Enter a number', ' ');
var answer = Math.sqrt(n);
alert ('The square root of ' + n + ' is '+ answer);

//Создайте функцию readNumber, которая будет запрашивать 
//ввод числового значения до тех пор, пока посетитель его не введёт.

function readNumber(){
    let num;
    do{
        num("Введите число", 0);
    } while (!isFinite(num));
    if (num === null | num === " ") return null;
    return +num;
}
alert('Число: ${readNumber()}');