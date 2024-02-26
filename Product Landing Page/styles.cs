body {
    display: flex;
    flex-direction: column;
    align-items: center;
}

header {
    position: sticky;
    top: 0;
    background-color: #333;
    padding: 10px;
    display: flex;
    justify-content: space-between;
    align-items: center;
}

nav {
    display: flex;
    justify-content: space-around;
    width: 30%;
}

nav a {
    color: white;
    text-decoration: none;
}

nav a:hover {
    text-decoration: underline;
}

@media screen and (max-width: 600px) {
    nav {
        flex-direction: column;
        width: 100%;
    }
}