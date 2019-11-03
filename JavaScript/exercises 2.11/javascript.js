function buttonClick(button){
  alert("Вы нажали на кнопку. Кнопка имеет имя "+ button.name + ", также" 
  + " value равно " + button.value + ".");
}

var counter1 = 0;
function counter(element){
  counter1++;
  element.innerHTML = "На этот текст было наведено " + counter1 + " раз";
}

function printTime(){
  var d = new Date();
  var hours = d.getHours();
  var mins = d.getMinutes();
  var secs = d.getSeconds();
  document.body.innerHTML = hours + ":" + mins +":"+ secs;
}
setInterval(printTime, 1000);