
window.momentDateR = (input) => {
    moment.locale('en-US'); // 'en'
    let m = moment(new Date(input));
    value = m.format('YYYY-MM-DD');
    return value;
}

window.momentDate = (input) => {
    moment.locale('en-US'); // 'en'
    let m = moment(new Date(input));
    value = m.format('DD/MM/YYYY');
    return value;
}

window.timeConvert = (time) => {
    // Check correct time format and split into components
    time = time.toString().match(/^([01]\d|2[0-3])(:)([0-5]\d)(:[0-5]\d)?$/) || [time];

    if (time.length > 1) { // If time format correct
        time = time.slice(1);  // Remove full string match value
        time[5] = +time[0] < 12 ? 'AM' : 'PM'; // Set AM/PM
        time[0] = +time[0] % 12 || 12; // Adjust hours
    }
    return time.join(''); // return adjusted time or original string
}

function showSuccessMessage(message = 'Saved successfully!') {
    Swal.fire({
        icon: 'success',
        title: 'Good Job',
        text: message,
        customClass: {
            confirmButton: "btn btn-primary"
        }
    });
}

function showErrorMessage(message = 'Something went wrong!') {
    Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: message.responseText !== undefined ? message.responseText : message,
        customClass: {
            confirmButton: "btn btn-primary"
        }
    });
}

function disableSubmitButton(btn) {
    $(btn).attr('disabled', 'disabled').attr('data-kt-indicator', 'on');
}

function onModalBegin() {
    disableSubmitButton($('#Modal').find(':submit'));
}

function onModalSuccess(row) {
    showSuccessMessage();
    $('#Modal').modal('hide');

    if (updatedRow !== undefined) {
        datatable.row(updatedRow).remove().draw();
        updatedRow = undefined;
    }

    var newRow = $(row);
    datatable.row.add(newRow).draw();
}

function onModalComplete() {
    $('body :submit').removeAttr('disabled').removeAttr('data-kt-indicator');
}

//Select2
function applySelect2() {
    $('.js-select2').select2();
    $('.js-select2').on('select2:select', function (e) {
        $('form').not('#SignOut').validate().element('#' + $(this).attr('id'));
    });
}
//$('body').delegate('.js-confirm', 'click', function () {
//    var btn = $(this);

//    bootbox.confirm({
//        message: btn.data('message'),
//        buttons: {
//            confirm: {
//                label: 'Yes',
//                className: 'btn-success'
//            },
//            cancel: {
//                label: 'No',
//                className: 'btn-secondary'
//            }
//        },
//        callback: function (result) {
//            if (result) {
//                $.post({
//                    url: btn.data('url'),
//                    data: {
//                        '__RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val()
//                    },
//                    success: function () {
//                        showSuccessMessage();
//                    },
//                    error: function () {
//                        showErrorMessage();
//                    }
//                });
//            }
//        }
//    });
//});