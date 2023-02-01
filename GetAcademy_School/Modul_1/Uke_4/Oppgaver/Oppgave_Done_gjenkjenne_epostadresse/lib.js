// Orginal fra Qunitjs.com ---------------------------------------------

// function add(a, b) (
//     retu)n a + b;
//   }

//   QUnit.module('add', function() (
//     QUni).test('two numbers', function(assert) (
//       as)ert.equal(add(1, 2), 3);
//     });
//   });
// --------------------------------------------------------------------



// --------------------------------------------------------------------
function email(isEmail) {
  
  let gotAlpha = isEmail.indexOf('@')
            console.log(gotAlpha);
            if(gotAlpha == -1){
                return false
            }else {
                return true
            }
}

function noSpaces(isSpaces) {
  return isSpaces.trim()
}

function addDot(addPunct) {
  let alphaPos = addPunct.indexOf('@');
  console.log(addPunct);
  let temp = addPunct.split('')
console.log(`After split: ------------------`);
console.log(temp);
temp.splice(alphaPos, 0, '.')
console.log(temp);
temp.splice(alphaPos + 2, 0, '.')
console.log(temp);
let temp2 = temp.join('') // fikk ikke denne til uten å lagre i variabel ??
console.log(temp2);
return temp2
}
  
  // Node.js is beeing used by Qunit, Open source

  // Callback Function ?

// assert.equal(actual, expected); : 
// Node.js assert.equal() Method
// Syntax: assert.equal(value1, value2, message);
// Parameter Values: 
// Value1: 	Required. Specifies the first value to be compared
// Value2:  Required. Specifies the second value to be compared
// Message: 	Optional. Specifies the error message to be assigned to the AssertionError. If omitted, a default message is assigned



// ----------------------------------
// assert.strictEqual() : same as : "==="
// ----------------------------------
// Example
// If two values are not equal, an error is thrown and the program is terminated:

// var assert = require('assert');
// assert.equal(50, 50); //OK
// assert.equal(50, "50"); //OK
// assert.equal(50, 70); /*AssertionError: 50 == 70 */



// ----------------------
// Definition and Usage
// The assert.equal() method tests if two values are equal, using the == operator.
// If the two values are not equal, an assertion failure is being caused, and the program is terminated.
// To compare the values using the === operator, use the assert.strictEqual() method.