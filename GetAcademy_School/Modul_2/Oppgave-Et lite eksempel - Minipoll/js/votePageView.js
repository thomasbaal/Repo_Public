function updateView_votePage() {
    console.clear();
    console.log('Currently at - votePageView -');

document.getElementById("voteApp").innerHTML = /*html*/ `
    <button onclick="goToOptionsPage()">Til alternativer siden</button>
    <ul>
        ${createVotesHtml()}
    </ul>
    `;
}


function createVotesHtml() {
    let htmlVotes = '';
   for(let i = 0; i < model.options.length; i++) {
    let option = model.options[i];
    htmlVotes += /*html*/ `
    <li>
        <button
            onclick="vote(${i})" 
            style="background-color:${option.color};width:65px;margin:3px"
            >${option.text}
        </button>
        ${model.options[i].voteCount ? ` - ${model.options[i].voteCount}` : ''}
    </li>
    `
}
    return htmlVotes;
}