function TesteCors() {
    var tokenJWT = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Impvc2VAZ21haWwuY29tIiwic3ViIjoiNDJiZGM2NTEtOTFiNC00OTM0LWJiYjktNjRkOWU3YThhMzZlIiwiZXhwIjoxNjg3MjExNDg5fQ.rQYLA6EBwmXRNRht_CsDVGtKjlQJColmHv_n3wG-8fc";
    var servico = "https://localhost:44327/api/mensagem/42bdc651-91b4-4934-bbb9-64d9e7a8a36e/abc12ade-47ca-4d65-8a10-33e577bf57d7";
    $("#resultado").html("---Solicitando---");
    $.ajax({
        url: servico,
        method: "GET",
        crossDomain: true,
        headers: { "Accept": "application/json" },
        beforeSend: function (xhr) {
            xhr.setRequestHeader("Authorization", "Bearer " + tokenJWT);
        },
        success: function (data, status, xhr) {
            $("#resultado").html(data);
            console.info(data);
        }
    });
}