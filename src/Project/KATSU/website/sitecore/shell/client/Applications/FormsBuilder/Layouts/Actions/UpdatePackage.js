﻿(function (speak) {

    var parentApp = window.parent.Sitecore.Speak.app.findApplication('EditActionSubAppRenderer'),

        designBoardApp = window.parent.Sitecore.Speak.app.findComponent('FormDesignBoard');

    var getFields = function () {

        var fields = designBoardApp.getFieldsData();

        return _.reduce(fields,

            function (memo, item) {

                if (item && item.model && item.model.hasOwnProperty("value")) {

                    memo.push({

                        itemId: item.itemId,

                        name: item.model.name

                    });

                }

                return memo;

            },

            [

                {

                    itemId: '',

                    name: ''

                }

            ],

            this);

    };

    speak.pageCode(["underscore"],

        function (_) {

            return {

                initialized: function () {

                    this.on({

                        "loaded": this.loadDone

                    },

                        this);

                    this.Fields = getFields();

                    this.MapProfileForm.children.forEach(function (control) {

                        if (control.deps && control.deps.indexOf("bclSelection") !== -1) {

                            control.IsSelectionRequired = false;

                        }

                    });

                    // this.ItemTreeView.on("change:SelectedItem", this.changedSelectedItemId, this);

                    if (parentApp) {

                        parentApp.loadDone(this, this.HeaderTitle.Text, this.HeaderSubtitle.Text);

                        parentApp.setSelectability(this, true);

                    }

                },

                changedSelectedItemId: function () {

                    parentApp.setSelectability(this, true, this.ItemTreeView.SelectedItemId);

                },

                setDynamicData: function (propKey) {

                    var componentName = this.MapProfileForm.bindingConfigObject[propKey].split(".")[0];

                    var component = this.MapProfileForm[componentName];

                    var items = this.Fields.slice(0);

                    if (this.Parameters[propKey] &&

                        !_.findWhere(items, { itemId: this.Parameters[propKey] })) {

                        var currentField = {

                            itemId: this.Parameters[propKey],

                            name: this.Parameters[propKey] +

                                " - " +

                                (this.ValueNotInListText.Text || "value not in the selection list")

                        };

                        items.splice(1, 0, currentField);

                        component.DynamicData = items;

                        $(component.el).find('option').eq(1).css("font-style", "italic");

                    } else {

                        component.DynamicData = items;

                    }

                },

                loadDone: function (parameters) {

                    this.Parameters = parameters || {};

                    _.keys(this.MapProfileForm.bindingConfigObject).forEach(this.setDynamicData.bind(this));

                    this.MapProfileForm.BindingTarget = this.Parameters;

                },

                getData: function () {

                    var formData = this.MapProfileForm.getFormData(),

                        keys = _.keys(formData);

                    keys.forEach(function (propKey) {

                        if (formData[propKey] == null || formData[propKey].length === 0) {

                            if (this.Parameters.hasOwnProperty(propKey)) {

                                delete this.Parameters[propKey];

                            }

                        } else {

                            this.Parameters[propKey] = formData[propKey];

                        }

                    }.bind(this));

                    return this.Parameters;

                }

            };

        });

})(Sitecore.Speak);