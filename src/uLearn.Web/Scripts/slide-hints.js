﻿function showHintForUser(courseId, slideIndex, hintsCount) {
    $.ajax({
        type: "POST",
        url: $("#GetHintButton").data("url"),
        data: { courseId: courseId, slideIndex: slideIndex, isNeedNewHint: true }
    }).success(function(ans) {
        if (ans.Text == "Для слайда нет подсказок") {
            $("#GetHintButton").notify("Для слайда нет подсказок", "noHints");
            return;
        } else if (ans.Text == "Подсказок больше нет") {
            $("#GetHintButton").notify("Подсказок больше нет :(", "noHints");
            return;
        } else {
            $('#hints-place').html(ans);
            if (!isScrolledIntoView('#hints-place')) {
                var container = $('body');
                container.animate({
                    scrollTop: $('#hints-place').offset().top - container.offset().top + container.scrollTop() - 200
                });
            }
        }
        buttonNameChange(hintsCount);
    }).fail(function(req) {
        console.log(req.responseText);
    }).always(function(ans) {
    });
}

function isScrolledIntoView(elem) {
    var docViewTop = $(window).scrollTop();
    var docViewBottom = docViewTop + $(window).height();
    var elemTop = $(elem).offset().top;
    var elemBottom = elemTop + $(elem).height();

    return ((elemBottom < docViewBottom) && (elemTop > docViewTop));
}

function getHints(courseId, slideIndex, hintsCount) {
    $.ajax({
        type: "POST",
        url: $("#GetHintButton").data("url"),
        data: { courseId: courseId, slideIndex: slideIndex, isNeedNewHint: false }
    }).success(function (ans) {
        if (ans.Text == "Для слайда нет подсказок") {
            $("#GetHintButton").text("NO HINTS");
            $("#GetHintButton").attr('disabled', 'disabled');
            return;
        } else if (ans.Text == "Подсказок больше нет") {
            $("#GetHintButton").text("NO MORE HINTS");
            return;
        } else {
            $('#hints-place').html(ans);
        }
        buttonNameChange(hintsCount);
    }).fail(function (req) {
        console.log(req.responseText);
    }).always(function (ans) {
    });

}


function buttonNameChange(hintsCount) {
    var showedHintsCount = 0;
    $(".like-button").each(function () {
        showedHintsCount++;
    });
    if (showedHintsCount < hintsCount && showedHintsCount != 0)
        $("#GetHintButton").text("NEXT HINT");
    else if (showedHintsCount != 0) {
        $("#GetHintButton").text("NO MORE HINTS");
        $("#GetHintButton").attr('disabled', 'disabled');
    }
}

function likeHint(courseId, slideId, hintId) {
    $.ajax({
        type: "POST",
        url: $("#" + hintId + "likeHint").data("url"),
        data: { courseId: courseId, slideId: slideId, hintId: hintId }
    }).success(function (ans) {
        if (ans == "success") {
            $("#" + hintId + "likeHint").removeClass("btn-default").addClass("btn-primary");
        }
        if (ans == "cancel") {
            $("#" + hintId + "likeHint").removeClass("btn-primary").addClass("btn-default");
        }
    });
}