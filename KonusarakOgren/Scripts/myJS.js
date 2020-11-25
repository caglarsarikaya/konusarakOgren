


$(document).ready(function () {

    $("#Select").change(function () {
        $.ajax({
                
                url: '/Home/GetContent/',
                type: 'POST',
                data: {
                    deger: $('#Select option:selected').val()
                },
                dataType: 'json',
                success: function (data) {
                    $("#Title").val($("#Select option:selected").text())
                    $("#content").html(data),
                    $("#examDesc").val($("#content").text());
                }
            });
        });



    $(".questionInput").change(function () {

        $(".questionOptions option").each(function () {

            if ($(this).attr("id") == "1a") {
                $(this).val($("#11Input").val());
                $(this).text($("#11Input").val());
            }
            if ($(this).attr("id") == "1b") {
                $(this).val($("#12Input").val());
                $(this).text($("#12Input").val());
            }
            if ($(this).attr("id") == "1c") {
                $(this).val($("#13Input").val());
                $(this).text($("#13Input").val());
            }
            if ($(this).attr("id") == "1d") {
                $(this).val($("#14Input").val());
                $(this).text($("#14Input").val());
            }
            if ($(this).attr("id") == "2a") {
                $(this).val($("#21Input").val());
                $(this).text($("#21Input").val());
            }
            if ($(this).attr("id") == "2b") {
                $(this).val($("#22Input").val());
                $(this).text($("#22Input").val());
            }
            if ($(this).attr("id") == "2c") {
                $(this).val($("#23Input").val());
                $(this).text($("#23Input").val());
            }
            if ($(this).attr("id") == "2d") {
                $(this).val($("#24Input").val());
                $(this).text($("#24Input").val());
            }
            if ($(this).attr("id") == "3a") {
                $(this).val($("#31Input").val());
                $(this).text($("#31Input").val());
            }
            if ($(this).attr("id") == "3b") {
                $(this).val($("#32Input").val());
                $(this).text($("#32Input").val());
            }
            if ($(this).attr("id") == "3c") {
                $(this).val($("#33Input").val());
                $(this).text($("#33Input").val());
            }
            if ($(this).attr("id") == "3d") {
                $(this).val($("#34Input").val());
                $(this).text($("#34Input").val());
            }
            if ($(this).attr("id") == "4a") {
                $(this).val($("#41Input").val());
                $(this).text($("#41Input").val());
            }
            if ($(this).attr("id") == "4b") {
                $(this).val($("#42Input").val());
                $(this).text($("#42Input").val());
            }
            if ($(this).attr("id") == "4c") {
                $(this).val($("#43Input").val());
                $(this).text($("#43Input").val());
            }
            if ($(this).attr("id") == "4d") {
                $(this).val($("#44Input").val());
                $(this).text($("#44Input").val());
            }

        });
    });




        });

