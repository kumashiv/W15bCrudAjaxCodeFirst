
$("button").click(function () {
    alert("Test");
    var Email = $('#Email').val();
    var Password = $('#Password').val();
    var FirstName = $('#txtFirstName').val();
    var LastName = $('#txtLastName').val();
    var Address = $('#Address').val();


    $.ajax({

        url: '/Home/Create',
        type: 'POST',
        data: {
            FirstName: FirstName,
            LastName: LastName,
            Address: Address,
            Email: Email,
            Password: Password
        },
        sucess: function (response) {
            alert("hhhh");
        }

    });

});