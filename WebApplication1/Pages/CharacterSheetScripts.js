function partialClass() { //trying to get a partial class option list to display when "Adventurer" is selected... WiP
    // Get the text box
    var classBox = CharacterSheet.getElementById("Class").value;
    // Get the output text
    var partialClassBox = CharacterSheet.getElementById("PartialClass").value;

    // If the checkbox is checked, display the output text
    if (classBox === "Adventurer") {
        CharacterSheet.getElementById("PartialClass").style.visibility = "visible";
    } else {
        CharacterSheet.getElementById("PartialClass").style.visibility = "hidden";
    }
}