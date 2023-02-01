function goToDeletePage(personId) {
    console.log(personId);
    model.app.currentPage = 'delete';
    // som en ekstra sjekk: setter personId
    model.inputs.delete.personId = personId;
    updateView();
}