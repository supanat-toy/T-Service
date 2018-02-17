// custom
(0, _jquery2.default)("#SetupProductGridField").jsGrid({
    height: "500px",
    width: "100%",

    inserting: true,
    editing: true,
    sorting: true,
    paging: true,

    data: db.users,

    fields: [{
      name: "Account",
      width: 150,
      align: "center"
    }, {
      name: "Name",
      type: "text"
    }, {
      name: "RegisterDate",
      type: "myDateField",
      width: 100,
      align: "center"
    }, {
      type: "control",
      editButton: false,
      modeSwitchButton: false
    }]
  });