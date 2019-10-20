
function bark(name, weight) {
  if (weight > 20) {
    console.log(name + " says WOOF WOOF");
    } else {
    console.log(name + " says woof woof");
    }
  }
bark("rover", 23);
bark("spot", 13);
bark("spike", 53);
bark("lady", 17);


function dogYears(dogName, age) {
  var years = age * 7;
  console.log(dogName + " is " + years + " years old");
  }
  dogYears ("Fido", 1);



  function makeTea(cups, tea) {
    console.log("Brewing " + cups + " cups of " + tea);
    }
    var guests = 3;
    makeTea(guests, "Earl Grey");


    function speak(kind) {
      var defaultSound = "";
      if (kind == "dog") {
      alert("Woof");
      } else if (kind == "cat") {
      alert("Meow");
      } else {
      alert(defaultSound);
      }
      }
      var pet = prompt("Enter a type of pet: ");
      speak(pet);


      function bake(degrees) {
        var message;

        if (degrees > 500) {
        message = "I'm not a nuclear reactor!";
        } else if (degrees < 100) {
        message = "I'm not a refrigerator!";
        } else {
        message = "That's a very comfortable temperature for me.";
        
        }
        return message;
        }
        var status = bake(350);


        function calculateArea (r) {
          var area;
          if (r<=0) {
            return 0;
          } else { 
          area = Math.PI * r * r;
          return area;
          }
        }
        var radius = 5.2;
        var theArea = calculateArea(radius);
        console.log("The area is: " + theArea);