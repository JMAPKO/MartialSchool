import 'package:flutter/material.dart';

class IconFondo extends StatelessWidget {

  final double y;
  final double x;

  final Color color;
  final double Size;

  IconFondo({
    this.y = 0,
    this.x = 0,
    this.color = Colors.white,
    this.Size = 50
    });

  @override
  Widget build(BuildContext context) {
    return Positioned(
        top: y,
        right: x,
        child: Icon(
          Icons.circle_outlined,
          size: Size,
          color: color,
        )
    );
  }
}
