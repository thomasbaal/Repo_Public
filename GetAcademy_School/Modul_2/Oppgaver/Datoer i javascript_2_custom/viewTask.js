function updateViewViewTask() {
let html = '';
html = /*html*/ `
    
    <p style="margin:10px;">Current User: ${model.app.currentUser}</p>
    <table>
        <tr>
            <th>Oppgave</th>
            <th>Utført</th>
            <th>Dato lagt til</th>
            <th>Dato Utført</th>
            <th>Ansvarlig</th>
            <th>⭐</th>
            <th>Rediger / slett</th>
        </tr>
    ${createHtmlRow()}

    </table>
    `

function createHtmlRow() {
    let task = '';
    let id = '';
    let userId = '';

    for(let i = 0; i < model.users.length; i++) {
        model.users[i].id = i;
    }

    for(let i = 0; i < model.tasks.length; i++) {
        let isDoneCheck = model.tasks[i].isDone
        let isDoneCheckStr = 'checked=checked'
        let taskDescriptionInput = document.getElementById("taskDescriptionId");
        let taskAddedInput = document.getElementById("taskAddedDate");
        let taskResponsibleInput = document.getElementById("taskResponsible");

        // sette id på array elements.
        model.tasks[i].id  = i;
        // legge til oppgavene


        return `
          <tr>
             <td>${model.tasks[i].description}</td>
             <td style="text-align:center;"><input onclick="checkChanged(${i})" ${isDoneCheck ? isDoneCheckStr : ''} type="checkbox" /></td>
             <td>${model.tasks[i].taskAdded}</td>
             <td>${model.tasks[i].taskCompleted}</td>
             <td>${model.tasks[i].responsible}</td>
             <td style="text-align:right;">${model.users[i].starCount}  ⭐</td>
             <td><button onclick="editTask(${i})">Rediger</button> <button>Slett</button></td>
        </tr>

        
        <table>
    <tr>
        <th>Legg til ny oppgave</th>
        <th>Ønsket utført</th>
        <th>Ansvarlig</th>
        <th>Lagre</th>
    </tr>
    <tr>
        <td style="text-align:center;"><input oninput="model.inputs.taskDescription=this.value" id="taskDescriptionId" type="text" /></td>
        <td><input oninput="model.inputs.taskAdded=this.value" type="date" /></td>
        <td style="text-align:center;"><input oninput="model.inputs.taskResponsible=this.value" type="text" /></td> 
        <td><button oninput="addTask()" >Lagre</button></td>
    </tr>

</table>

    `

    }



}

    document.getElementById("taskApp").innerHTML = html;

}


function checkChanged(index) {
    model.tasks[index].isDone  ? model.tasks[index].isDone = false  : model.tasks[index].isDone = true;
    console.log(model.tasks[index].isDone);
    updateView()
}


function editTask(index) {
    model.tasks[index].editMode = true;
    updateView()
}

function addTask(element, index) {
    let task = model.inputs.taskDescription
    console.log(task);
   model.tasks.push({id: '', description: model.inputs.taskDescription, responsible: '', taskAdded: '', taskCompleted: '', isDone: false, editMode: false})
}

// {id: '', description: 'Spille Death Stranding', taskOwner: 'Thomas', taskAdded: '2022.08.24', isDone: true},


/*

  <input type="checkbox" id="switch" class="checkbox" />

        <label for="switch" class="toggle">


<td><input onclick="checkChanged(${i})" ${isDoneCheck ? isDoneCheckStr : ''} type="checkbox" /></td>

*/