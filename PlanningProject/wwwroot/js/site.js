function validateLoginForm() {
    const username = document.getElementById('username').value;
    
    if (!username) {
        alert('A felhasználónév mező nem lehet üres. Kérem írjon be egy érvényes felhasználónevet.');
        return false;
    }
    return true;
}

document.addEventListener('DOMContentLoaded', function() {
    const loginForm = document.getElementById('loginForm');
    if (loginForm) {
        loginForm.addEventListener('submit', function(e) {
            if (!validateLoginForm()) {
                e.preventDefault();
            }
        });
    }
});

function handleSubmit(event) {
    event.preventDefault();
    const username = document.getElementById('usernameInput').value.trim();

    if (username) {
        alert(`Üdvözlöm, ${username}! Sikeresen helyet foglalt a Planning Poker asztalnál.`);
    } else {
        alert('A felhasználónév mező nem lehet üres. Kérem írjon be egy érvényes felhasználónevet.');
    }
}
