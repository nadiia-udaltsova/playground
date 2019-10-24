let user = {
    name: "John",
    age: 30,
    profeccion: "driver",
    cars: ["toyota", "ford", "mazda", "bmw"],
    sayHi: function (){
        console.log("Hello from Kyiv! My name is " + this.name)
    }

};
let arrsCars = user.cars.join(','); //String.join(",", user.cars); 
console.log(arrsCars);
for (let i=0; i<user.cars.length; i++){
    console.log(user.cars[i]);
}
user.name = "Roma";
user.sayHi();
console.log(user.age);


function getTitle(){
    return "This is title";
}

let xxx = getTitle();

console.log(getTitle())