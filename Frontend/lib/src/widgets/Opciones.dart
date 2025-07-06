import 'package:flutter/material.dart';


class Opcion extends StatelessWidget {

  final String titulo;
  final Color color;

  //Constructor por defecto
  Opcion({
    this.titulo = "Titulo por defecto" ,
    this.color = const Color.fromRGBO(120, 50, 180, 1),
    super.key,
  });

  @override
  Widget build(BuildContext context) {
    return GridTile(child: Container(
        padding: EdgeInsets.all(8),
        margin: EdgeInsets.all(20),
        decoration: BoxDecoration(
            borderRadius: BorderRadius.circular(20),
            color: color,
            boxShadow: [BoxShadow(
                color: Colors.black87,
                blurRadius: 10,
                offset: Offset(2, 10),
                spreadRadius: 1
            )]
        ),
        child: Center(child: Text(titulo, style: TextStyle(
            color: Colors.white,
            fontWeight: FontWeight.bold,
            fontSize: 18,
            fontStyle: FontStyle.italic
        ),))
    ));
  }
}
