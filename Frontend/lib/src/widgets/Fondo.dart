

import 'package:flutter/material.dart';

class Fondo extends StatelessWidget {
  const Fondo({super.key});

  @override
  Widget build(BuildContext context) {
    return Container(
      height: double.infinity,
      width: double.infinity,
      decoration: BoxDecoration(
        gradient: LinearGradient(
            colors: [
              Colors.red[500]!,
              Colors.orange[300]!,
              Colors.blue[100]!
            ]),
      ),
    );
  }
}
