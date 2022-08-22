// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*This is for Search Bar*/
function openPage() {
    var userInput = document.getElementById("search").value;
    if (userInput === "City" || userInput ==="city") {
        window.open("https://localhost:44331/Pages/City");
    }
    if (userInput === "Rise" || userInput === "rise") {
        window.open("https://localhost:44331/Pages/Rise");
    }
    if (userInput === "Dawn" || userInput === "dawn") {
        window.open("https://localhost:44331/Pages/Dawn");
    }
    if (userInput === "Dive" || userInput === "dive") {
        window.open("https://localhost:44331/Pages/Dive");
    }
    else {
        alert("You've entered invalid item");
    }
}


/*-----------------------This is for Login-----------------------*/
function validate() {
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;

    if (username == "admin" & password == "user") {
        alert("Login Successfully!");
        window.open("https://localhost:44331/WatchCatalogs/Index")
        return false;
    }

    else {
        alert("Login Failed, Please try again and check your credentials.");
    }
}