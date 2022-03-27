var i = 1;
function Add() {
    var ForDynamic = document.getElementById("ForDynamic");
    var p = document.createElement("tr");
    var q = document.createElement("td");
    var r = document.createElement("input");
    r.name = `[${i}].ItemName`;
    r.type = Text;

    q.append(r);
    p.append(q);
    var q2 = document.createElement("td");
    var r2 = document.createElement("input");
    r2.name = `[${i}].ItemQuantity`;
    r2.type = Text;

    q2.append(r2);
    p.append(q2);
    var q3 = document.createElement("td");
    var r3 = document.createElement("input");
    r3.name = `[${i}].ItemPrice`;
    r3.type = Text;
    q3.append(r3);
    p.append(q3);
    ForDynamic.append(p);
    i++;
}