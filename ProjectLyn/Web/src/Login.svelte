<script>
    let id="";
    let pw="";

    function Login()
    {

    }
</script>

<body>
    <div id="login">
        <div id="container">
            <div id="top">
                <h2>TITLE</h2>
            </div>
            <div id="bottom">
                <div class="item">
                </div>
                <div class="item">
                    <input bind:value={id} type="email" placeholder="ID" />
                </div>
                <div class="item">
                    <input
                        bind:value={pw}
                        type="password"
                        placeholder="Password"
                    />
                </div>
                <div class="item"><button on:click={Login}>Login</button></div>
            </div>
        </div>
    </div>
</body>