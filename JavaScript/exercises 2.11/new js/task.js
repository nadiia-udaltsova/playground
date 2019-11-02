/*function timerHandler() {
    alert("Hey what are you doing just sitting there staring at a blank screen?");
    }
    setTimeout(timerHandler, 5000);*/

var tick = true;
function ticker() {
if (tick) {
console.log("Tick");
tick = false;
} else {
console.log("Tock");
tick = true;
}
}
var t = setInterval(ticker, 1000);
clearInterval(t);