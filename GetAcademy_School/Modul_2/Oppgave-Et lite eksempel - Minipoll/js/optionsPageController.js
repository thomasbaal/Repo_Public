function goToVotePage() {
    model.app.currentPage = 'votePage'
    updateView()
}

function addOption() {
    let option = model.inputs.optionsPage.newOption;
    model.options.push({text: option, color: 'grey'})
    model.inputs.optionsPage.newOption = '';
    updateView()
}