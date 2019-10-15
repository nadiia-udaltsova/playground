let i = 0;
while (i < 3) {
    alert (i);
    i++;
}

let r = 0;
do {
  alert( r );
  i++;
} while (r < 3);


for (let i = 0; i < 10; i++){
    if (i % 2 == 0) continue; 
        alert (i);
    
}

let insertNumber;
do {
    insertNumber = prompt ("Введите число > 100", 0);
} while (insertNumber <= 100 || null)

let user = {
  name: "John",
  age: 30,
  "likes birds": true
};
alert (user.name);
alert (user.age);
alert (user ["likes birds"]);



function makeUser (name, age){
  return {
    name: name,
    age: age,
  };
}
let newUser = makeUser ("Ruslan", 45);
alert (newUser.name);

let user = {
  name: "Kirill",
  age: 29, 
  isAdmin: true,
};
for (key in user) {
  alert (key);
  alert (user[key]);
}

let user = {
  name: "John",
  surname: "Smith",
};
user.name = "Pete";
delete user.name;



let salaries = {
  John = 100,
  Ann = 130,
  Pete = 200,
};

let sum = 0;
for (key in salaries) {
  sum += salaries[key];
}
alert (sum);




function multiplyNumeric(obj) {
  for (key in obj) {
    if (typeof obj[key] == "number") {
      obj[key] *=2;
    }
  }
}