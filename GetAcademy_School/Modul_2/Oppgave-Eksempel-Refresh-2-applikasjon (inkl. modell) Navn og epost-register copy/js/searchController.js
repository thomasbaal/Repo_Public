
function goToDeletePage(personId) {
console.log('goToDeletePage() - Current person.id' + ' ' + personId);
// console.log(personId); // 1, 2 o.s.v - works
model.app.currentPage = 'delete'; // setter hvem side vi skal til ved neste kall på updateView()
console.log('currentPage - set to - "delete"');
model.inputs.delete.personId = personId; // setter personId i model før nytt kall på updateView.
console.log('model.inputs.delete.personId - set to - personId');
updateView()
}

function goToEditPage(personId) {
    console.log('goToEditPage() - Current person.id' + ' ' + personId);
    model.app.currentPage = 'edit'
    console.log('currentPage - set to - "edit"');
    model.inputs.edit.personId = personId;
    // når vi går til den aktuelle personen som her, så setter vi properties i modellen på forhånd(model.inputs.edit.name og email)
    // men vi trenger å finne personen, vi bruker den funksjone vi laget tidligere(findPersonById) da vi har med oss parametere "personId"

    const person = findPersonById(personId)
    model.inputs.edit.name = person.name;
    model.inputs.edit.email = person.email;
        
    
    updateView()
}