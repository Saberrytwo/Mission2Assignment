//Javascript program that occurs when the calculate grade button is pressed. Takes outputs from the html form and calculates the final grade.
//It then outputs that final grade along with a brief message to a paragraph tag.
$("#calc").click(function () {
    var output = "";
    var ass = (parseInt($("#ass").val()) * .55);
    var group = parseInt($("#group").val()) * .05;
    var quiz = parseInt($("#quiz").val()) * .1;
    var exam = parseInt($("#exam").val()) * .2;
    var int = parseInt($("#int").val()) * .1;
    var finalGrade = ass + group + quiz + exam + int;
    finalGrade = Math.round(finalGrade);
    output = "Your final grade in IS413 is: " + finalGrade + "%";
    document.getElementById("output").innerHTML = output;
})