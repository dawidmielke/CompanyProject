function taskDatesCorrect() {
    let date1 = $("#TaskStart").val()
    let date2 = $("#TaskEnd").val()
    if (date1 == null || date2 == null) {
        return null;
    }

    date1 = new Date(date1);
    date2 = new Date(date2);
    if (date1.getFullYear() == date2.getFullYear() && date1.getMonth() == date2.getMonth() && date1.getDay() == date2.getDay()) {
        $("#date-error").html("")
        $("#task-submit").show()
    }
    else {
        $("#date-error").html("Task should start and end at the same day")
        $("#task-submit").hide()
    }
}


$(document).ready(function () {
    $("#TaskStart").change(function () {
        taskDatesCorrect()
    })

    $("#TaskEnd").change(function () {
        taskDatesCorrect()
    })
})


const yearEl = document.querySelector(".year");
const currentYear = new Date().getFullYear();
yearEl.textContent = currentYear;