//function validateLoginForm() {
//    const username = document.getElementById('username').value;

//    if (!username) {
//        alert('A felhasználónév mező nem lehet üres. Kérem írjon be egy érvényes felhasználónevet.');
//        return false;
//    }
//    return true;
//}

//document.addEventListener('DOMContentLoaded', function() {
//    const loginForm = document.getElementById('loginForm');
//    if (loginForm) {
//        loginForm.addEventListener('submit', function(e) {
//            if (!validateLoginForm()) {
//                e.preventDefault();
//            }
//        });
//    }
//});

function handleSubmit(event) {
    const username = document.getElementById('usernameInput').value.trim();

    if (!username) {
        alert('A felhasználónév mező nem lehet üres, kérem írjon be egy érvényes felhasználónevet.');
    }
}

//function handleSprintSubmit() {
//    document.getElementById('postButton').addEventListener('click', async () => {
//        try {
//            const response = await fetch('/Lobby', {
//                method: 'POST'
//            });

//            if (response.ok) {
//                console.log('Request successful');
//                // Handle successful response (e.g., update UI)
//            } else {
//                console.error('Request failed', response.statusText);
//            }
//        } catch (error) {
//            console.error('Error:', error);
//        }
//    });
//}