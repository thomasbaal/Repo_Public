function updateViewEdit() {
    console.log('Switched to editview');

    document.getElementById("registerApp").innerHTML = /*html*/ `
    
    ${createMenuHtml()}
    <hr>
    <h3>Rediger</h3>
    ${createPersonEditHtml()} 
    <button onclick="editPerson()">Rediger</button>
    
    


    `
}

function createPersonEditHtml() {
    // henter opp id og lagrer til variabel.
    const personId = model.inputs.edit.personId;
    // sender parameter til en "find funksjon" som er lagret i common.js
    let person = findPersonById(personId);
    console.log(person);

    // findPersonById funksjonen finner å lagrer dette i variabelen person.
    // under returner vi med resultatet som ble funnet å lagret i  person tilbake til kalleren.

    return /*html*/ `
        Navn: <br/>
        <input type="text" 
            value="${model.inputs.edit.name}" 
            oninput="model.inputs.edit.name=this.value"
        /> <br/>

        E-post: <br/>
        <input type="text" 
            value="${model.inputs.edit.email}"
            oninput="model.inputs.edit.email=this.value"
        /> <br/>
    `


}



















