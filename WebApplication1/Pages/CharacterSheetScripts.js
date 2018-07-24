function partialClass() { //trying to get a partial class option list to display when "Adventurer" is selected... WiP
    // Get the text box
    var classBox = CharacterSheet.getElementById("Class");
    // Get the output text
    var partialClassBox = CharacterSheet.getElementById("PartialClass");

    // If the checkbox is checked, display the output text
    if (classBox === "Adventurer") {
        partialClass.style = "visible";
    } else {
        partialClass.style = "hidden";
    }
}