class App extends React.Component {
    render() {
      const App = "Multimedia Buttons";
      const Author = "maciekkoks";
      const Mail = "maciekt07@gmail.com";
      const Github = "https://github.com/maciekkoks";
      const Year = new Date().getFullYear();
      const Features = [
        "Now Playing Spotify Song In App Title",
        "Stop All",
        "Mute",
        "Open Spotify.exe (Microsoft Store Version Only)",
        "Volume Down",
        "Volume Up",
        "Previous Track",
        "Play/Pause",
        "Next Track",
        "Skip ads button for Spotify (plz dont sue me)",
      ];
  
      function emoji_change() {
        const emoji = document.getElementById("emoji");
        if (emoji.innerText === "🔊") {
          emoji.innerText = "🔉";
        } else if (emoji.innerText === "🔉") {
          emoji.innerText = "🔈";
        } else {
          emoji.innerText = "🔊";
        }
      }
  
      return (
        <div id="top">
          <header>
            <h1 class="headertxt animate__animated animate__headShake" >{App}</h1>
            <p class="headerdes animate__animated animate__fadeIn">
              Multimedia control application with built-in AdBlocker for Spotify
            </p>
            <div class="buttons">
              <button
                class="button1"
                onClick={() =>
                  window.open(
                    "https://github.com/maciekkoks/multimedia-buttons",
                    "_blank"
                  )
                }
              >
                View on github
              </button>
              <button
                class="button1"
                onClick={() =>
                  window.open("App/Multimedia Buttons V1.3.5.zip", "_self")
                }
              >
                Download.zip
              </button>
            </div>
            <br />
          </header>
          <main>
            <div class="imgbaner animate__animated animate__fadeInRight">
              <a
                href="https://marketplace.visualstudio.com/items?itemName=maciekkoks.luvia-theme"
                target="_blank"
                title="Theme: Luvia Theme"
              >
                <img class="mainimg" src="https://raw.githubusercontent.com/maciekkoks/Multimedia-Buttons/Website/Img/luvia%20theme%20baner.png" />
              </a>
            </div>
            <div class="animate__animated animate__fadeInLeft">
            <p class="h">⏯ About</p>
            <p class="d">
              <b>{App}</b> V1.3.5  Multimedia control app with built-in{" "}
              <a href="#adblocker">AdBlocker</a> for Spotify. Made in Visual Studio using{" "}
              <a
                href="https://github.com/maciekkoks?tab=repositories&q=&type=&language=c%23&sort="
                target="_blank"
              >
                C#
              </a>{" "}
              And Windows Forms. Application uses{" "}
              <a
                href="https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes"
                target="_blank"
              >
                Virtual Keys
              </a>
              .
            </p>
          
            <p>
              <a
                class="d"
                href="https://github.com/maciekkoks/Multimedia-Buttons"
                target="_blank"
              >
                ➜ App Repository
              </a>
              <br />
  
              <a
                class="d"
                href="https://github.com/maciekkoks/Multimedia-Buttons/tree/Website"
                target="_blank"
              >
                ➜ Website Repository
              </a>
            </p>
          </div>
            <img
              class="preview"
              src="https://raw.githubusercontent.com/maciekkoks/Multimedia-Buttons/Website/Img/previewmain.png"
            />
            <p>
              First version: September 2021
              <br />
              1.3.5 version: December 2021
            </p>
            <br />
            <p class="h">
              <span id="emoji" onClick={() => emoji_change()}>
                🔊
              </span>{" "}
              Features
            </p>
            <div class="features">
              <ul class="d">
                <li>
                  {Features.map((Features) => (
                    <li class="d">{Features}</li>
                  ))}
                </li>
              </ul>
            </div>
            <br />
            <p id="adblocker" class="h">
              📛 AdBlocker
            </p>
            <p class="d">
              AdBlocker for{" "}
              <a
                href="https://open.spotify.com/playlist/5wTHxmdjOtkOx3hfBGBdIN?si=d30b7735369746b3"
                target="_blank"
                class="spoti"
              >
                Spotify
              </a>
              &nbsp;only works for Microsoft Store version
            </p>
            <img
              class="preview"
              src="https://raw.githubusercontent.com/maciekkoks/Multimedia-Buttons/Website/Img/skipad.png"
            />
            <br />
            <br />
            <p class="d">AdBlocker Code</p>
            <a
              href="https://marketplace.visualstudio.com/items?itemName=maciekkoks.luvia-theme"
              target="_blank"
            >
              <img
                id="ad"
                src="https://raw.githubusercontent.com/maciekt07/Multimedia-Buttons/Website/Img/d.png" title="Theme: Luvia Theme"
              />
            </a>
            <p class="d">
              <a
                href="https://github.com/maciekkoks/Multimedia-Buttons/tree/main/Multimedia-Buttons"
                target="_blank"
              >
                View full code
              </a>
            </p>
            <br />
            <p class="h">🐛 Issues</p>
            <p class="d">
              If you found an issue, you can report it in the{" "}
              <a
                href="https://github.com/maciekkoks/Multimedia-Buttons/issues"
                target="_blank"
              >
                github issues
              </a>
              .
            </p>
            <p class="h">💌 License</p>
            <p class="d">
              Under the <a href="LICENSE">MIT License</a>
            </p>
            <p class="d">
              © 2021-{Year}{" "}
              <a href={Github} target="_blank">
                {Author}
              </a>{" "}
              - {Mail}
            </p>
            <br />
            <button
              class="backtotop"
              onClick={() => window.open("#root", "_self")}
            >
              Back To Top
            </button>
          </main>
  
          <footer>
            Made With 💜 By{" "}
            <a href={Github} target="_blank">
              {Author}
            </a>
            <br />
            <div class="socials">
              <i class="fab fa-twitter"></i>
              <i class="fab fa-github"></i>
              <i class="fab fa-spotify"></i>
            </div>
          </footer>
        </div>
      );
    }
  }
  
  ReactDOM.render(<App />, document.getElementById("root"));