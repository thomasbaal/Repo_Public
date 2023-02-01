function updateView_optionsPage() {
    console.clear();
    console.log('currently at - optionsPageView -');
    document.getElementById("voteApp").innerHTML = /*html*/ `
    <button onclick="goToVotePage()" >Til Stemme siden</button>
    <hr>
    Nåværende alternativer:
    <ul>
        ${createOptionsHtml()}
    </ul>
    Nytt alternativ: <br/>
    <input 
        oninput="model.inputs.optionsPage.newOption=this.value" 
        value="${model.inputs.optionsPage.newOption || ''}"
        type="text"
    />
    <button onclick="addOption()">Legg til</button>
        
    `;
}

function createOptionsHtml() {
    let htmlVotes = '';
    for(let i = 0; i < model.options.length; i++) {
     let option = model.options[i];
     htmlVotes += /*html*/ `
     <li>
        ${option.text}
     </li>
     `
 }
     return htmlVotes;
 }
