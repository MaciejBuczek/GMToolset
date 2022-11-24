"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/quickSessionHub").build();

//Disable the send button until connection is established.
document.getElementById("createButton").disabled = true;

connection.on("ReceiveMessage", function (participant) {
    var li = document.createElement("li");
    document.getElementById("participantsList").appendChild(li);
    li.textContent = `${participant.name}`;
});

connection.start().then(function () {
    document.getElementById("createButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("createButton").addEventListener("click", function (event) {
    let participant = {};
    let participantFields = Array.from(document.getElementsByClassName("participant-create"));

    participantFields.forEach(field => {
        participant[field.dataset.objectName] = field.getAttribute("type") == "checkbox" ? field.checked : field.value;
    });

    let dupa = {
        Name: participant.Name,
        MaxHp: participant.MaxHp,
        CurrentHp: participant.CurrentHp,
        IsMpApplicable: participant.IsMpApplicable,
        MaxMp: participant.MaxMp,
        CurrentMp: participant.CurrentMp,
        IsStApplicable: participant.IsStApplicable,
        MaxSt: participant.MaxSt,
        CurrentSt: participant.CurrentSt,
        Initiative: participant.Initiative,
        DamagePerRound: participant.DamagePerRound,
        ExtraInfo: participant.ExtraInfo
    };

    connection.invoke("SendMessage", 
        participant
    ).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});