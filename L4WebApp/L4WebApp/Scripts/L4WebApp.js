$(function() {
    $.validator.addMethod("telnum", function(value, element) {
        return this.optional(element) || /^[\+]?[\s\d]{8,15}$/.test(value);
    }, "Please enter a valid phone number. (Only numbers, 8-15 characters)");

    $.validator.addMethod("strictermail", function(value, element) {
        return this.optional(element) || /^[a-z0-9._+-]+@[a-z0-9.-]+\.[a-z]{2,4}$/.test(value);
    }, "Please enter a valid email address.");

    $("#addForm").validate({
        onkeyup: false,
        onfocusout: false,
        onsubmit: true,
        rules: {
            Fname: {
                required: true,
                remote: {
                    url: "Home/RemoteCheckName",
                    type: "post",
                    data: {
                        input: function() {
                            return $("#addFirstName").val();
                        }
                    }
                }
            },
            Lname: {
                required: true,
                remote: {
                    url: "Home/RemoteCheckName",
                    type: "post",
                    data: {
                        input: function () {
                            return $("#addLastName").val();
                        }
                    }
                }
            },
            Telnum: { required: true, telnum: true },
            Email: { required: true, email:true, strictermail: true }
        },
        highlight: function(element) {
            $(element).closest(".form-group").addClass("has-error");
        },
        unhighlight: function(element) {
            $(element).closest(".form-group").removeClass("has-error");
        },
        errorElement: "span",
        errorClass: "help-block",
        submitHandler: function(form) {
            var valuesArr = new Array();
            valuesArr[0] = $("#addFirstName").val();
            valuesArr[1] = $("#addLastName").val();
            valuesArr[2] = $("#addTelephone").val();
            valuesArr[3] = $("#addEmail").val();

            var data = { values: valuesArr };

            $.ajax({
                type: "POST",
                url: "/Home/Create",
                data: data,
                dataType: "json",
                traditional: true,
                success: function (result) {
                    if (result === true) {
                        $("#addForm :input").each(function () {
                            $(this).val("");
                        });
                        updateContacts();
                    } else {
                        console.log(result);
                    }
                    $("#addFirstName").focus();
                }
            });
            return false;
        }
    });
});


$("#contactTable").on("click", "tbody > tr", function(e) {
    e.preventDefault();
    $(this).toggleClass("info");
});
 


$("#k-remove").on("click", function(e) {
    e.preventDefault();
    var activated = new Array();
    $("tr.info").each(function() {
        activated.push($(this).data("attribute"));
    });

    $.ajax({
        type: "POST",
        url: "/Home/Delete",
        data: { ids: activated },
        traditional: true,
        success: function(result) {
            if (result != false) {
                updateContacts();
            }
        }
    });
});

function updateContacts() {
    $.ajax({
        url: "/Home/GetContacts",
        type: "GET",
        success: function(resultView) {
            $("#contactTable").html(resultView);
        }
    });
}