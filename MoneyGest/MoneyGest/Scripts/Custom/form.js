var moneyGest = moneyGest || {};
(function (skillet, $, undefined) {
    skillet.init = function () {
        $("form")
            .on("submit", skillet.submitFormEvent)
    }
    skillet.submitFormEvent = function (evt) {
        evt.preventDefault();
        skillet.submitAjaxForm($(this), evt);
    }
    skillet.getSubmitButton = function ($form) {

    }
    skillet.submitAjaxForm = function submitAjaxForm($form,evt) {
       
        $.ajax({
            type: $form.attr("method"),
            url: $form.attr("action"),
            data: $form.serialize(),
            success: function (data) {

                debugger;
            }

        })
        debugger;
    }

})(moneyGest = moneyGest.login || {}, jQuery)
$(function () {
    moneyGest.init();
})