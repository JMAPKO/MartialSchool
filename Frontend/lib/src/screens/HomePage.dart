import 'package:flutter/material.dart';
import 'package:pakuayb/src/widgets/Fondo.dart';
import 'package:pakuayb/src/widgets/Icon.dart';

import '../widgets/Contenedor.dart';

class Homepage extends StatelessWidget {

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Stack(
        children: [
          //Fondo,
          Fondo(),
          IconFondo(Size: 800, x: -50, y: 50, color: Colors.grey[100]!,),
           //Grid de objetos
          Contenedor()
        ],
      ),
    );
  }
}


