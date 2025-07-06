import 'package:flutter/material.dart';
import 'package:pakuayb/src/widgets/Fondo.dart';

class Alumnos extends StatelessWidget {

  final List<String> alumnos = [
    "jorge","matias", "rosita", "georgina"
  ];

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Stack(
        children: [

          Fondo(),

           //Lista prototipo
           ListView.builder(
                itemCount: alumnos.length,
                itemBuilder: (context, i) {
                  return Card(
                    child: ListTile(
                      title: Text("${alumnos[i]}"),
                      trailing: Text("edad"),
                      leading: Icon(Icons.arrow_drop_down_rounded),
                    ),
                  );
                },
           ),
        ],
      )
    );
  }
}
