
import 'package:flutter/material.dart';
import 'package:pakua_yb/widgets/ImageHome.dart';

import '../widgets/background_theme.dart';

class HomePage extends StatelessWidget {


  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Stack(
        children: [

          //Background
          BackgroundTheme(),

          //HomeBody
          _HomeBody()


        ],
      )
    );
  }
}

class _HomeBody extends StatelessWidget {
  const _HomeBody({
    super.key,
  });

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(

      child: Column(
        children: [
            Imagehome()
        ],
      ),
    );
  }
}


