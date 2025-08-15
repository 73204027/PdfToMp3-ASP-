const dynamicDiv = document.getElementById("dynamicDiv");
const form = document.getElementById("uploadForm");

form.addEventListener("submit", (e) => {
    e.preventDefault;

    const formData = new FormData(form);

    const response = await fetch("/upload", {
        method: 'POST',
        body: formData,
      })
        .then(response => response.text())
        .then(html => {
            // inject/modify HTML container
            dynamicDiv.innerHTML = html;
        })
    



    



}

)


