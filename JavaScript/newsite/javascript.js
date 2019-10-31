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