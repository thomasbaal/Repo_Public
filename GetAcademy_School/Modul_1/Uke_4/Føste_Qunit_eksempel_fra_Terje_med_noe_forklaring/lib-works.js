// Orginal fra Qunitjs.com ---------------------------------------------

// function add(a, b) {
//     return a + b;
//   }

//   QUnit.module('add', function() {
//     QUnit.test('two numbers', function(assert) {
//       assert.equal(add(1, 2), 3);
//     });
//   });
// --------------------------------------------------------------------



// --------------------------------------------------------------------
function reverseText(text) {
  return text.split('').reverse().join('');
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