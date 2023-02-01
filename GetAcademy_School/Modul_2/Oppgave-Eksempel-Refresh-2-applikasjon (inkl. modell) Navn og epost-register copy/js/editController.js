function editPerson() {
    // her skal vi finne personen.tar i bruk funksjonen laget fra tidligere.

    const person = findPersonById(model.inputs.edit.personId) // Note! model.inputs.edit.personId blir en sti til modellen, selv i et parameter.!!
    person.name = model.inputs.edit.name;
    person.email = model.inputs.edit.email;
    model.app.currentPage = 'search' 
    updateView()
}