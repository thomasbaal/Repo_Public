// Model
let html = '';
let screen = 'login';

let isLoggedIn = '';
let userName = '';
let passWord = '';
let errMsg = '';



// View
viewApp()
function viewApp() {
    if(screen == 'main') {
        secretPage()
    }else if (screen = 'login') {
        html = '';
        html += /*html*/ `
        <div style="font-family: cursive ; font-size:30px; ">The Simpsons Login ! </div>
        <input placeholder="Username:" type="text" oninput="userName=this.value" value="${userName ? userName : ''}"/>
        <input placeholder="Password:" type="text" oninput="passWord=this.value" value="${passWord ? passWord : ''}"/> <br/>
        <button onclick="logIn()">Log in</button> <div style="color:red; font-size:larger;">${errMsg}</div>
        
        `
        document.getElementById("appDiv").innerHTML = html;


    }
        
}




function secretPage() {
    html = '';
    html += /*html*/ `
    <div>${loggedIn ? loggedIn : ''}</div>
    <div style="font-family: cursive ; font-size: 30px; ">We Wont keep eny secrets for each other..</div>
    <p><em>As you can see.... It's nothing here</em></p>

    ` 
    document.getElementById("appDiv").innerHTML = html;
}



// Controller

function logIn(){
    if(userName === 'thomas' && passWord === '1') {
    screen = 'main';
    loggedIn = userName;
    // alert('ah correct')
    }else {
        errMsg = 'Durp!! - Wrong !, Try again'
    }
    viewApp()
}


